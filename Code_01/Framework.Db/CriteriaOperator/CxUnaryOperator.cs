/********************************************************************
 *  FulcrumWeb RAD Framework - Fulcrum of your business             *
 *  Copyright (c) 2002-2010 FulcrumWeb, ALL RIGHTS RESERVED         *
 *                                                                  *
 *  THE SOURCE CODE CONTAINED WITHIN THIS FILE AND ALL RELATED      *
 *  FILES OR ANY PORTION OF ITS CONTENTS SHALL AT NO TIME BE        *
 *  COPIED, TRANSFERRED, SOLD, DISTRIBUTED, OR OTHERWISE MADE       *
 *  AVAILABLE TO OTHER INDIVIDUALS WITHOUT EXPRESS WRITTEN CONSENT  *
 *  AND PERMISSION FROM FULCRUMWEB. CONSULT THE END USER LICENSE    *
 *  AGREEMENT FOR INFORMATION ON ADDITIONAL RESTRICTIONS.           *
 ********************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Db
{
  /// <summary>
  /// A criteria operator, represents some unary operations.
  /// </summary>
  public class CxUnaryOperator: CxCriteriaOperator
  {
    //----------------------------------------------------------------------------
    private NxUnaryOperatorType m_OperatorType;
    private CxCriteriaOperator m_Operand;
    //----------------------------------------------------------------------------

    #region Properties
    //----------------------------------------------------------------------------
    /// <summary>
    /// A type of the unary operator.
    /// </summary>
    public NxUnaryOperatorType OperatorType
    {
      get { return m_OperatorType; }
      set { m_OperatorType = value; }
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// The main operand of the operator.
    /// </summary>
    public CxCriteriaOperator Operand
    {
      get { return m_Operand; }
      set { m_Operand = value; }
    }
    //----------------------------------------------------------------------------
    #endregion

    #region Ctors
    //----------------------------------------------------------------------------
    /// <summary>
    /// Default ctor.
    /// </summary>
    public CxUnaryOperator()
    {
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="operand"></param>
    public CxUnaryOperator(NxUnaryOperatorType type, CxCriteriaOperator operand)
      : this()
    {
      OperatorType = type;
      Operand = operand;
    }
    //----------------------------------------------------------------------------
    #endregion

    //----------------------------------------------------------------------------
    /// <summary>
    /// Clones the criteria operator.
    /// </summary>
    /// <returns>returns a clone</returns>
    public override CxCriteriaOperator Clone()
    {
      return new CxUnaryOperator(OperatorType, Operand.Clone());
    }
    //----------------------------------------------------------------------------
    ///<summary>
    ///Returns an enumerator that iterates through the collection.
    ///</summary>
    ///
    ///<returns>
    ///A <see cref="T:System.Collections.Generic.IEnumerator`1"></see> that can be used to iterate through the collection.
    ///</returns>
    ///<filterpriority>1</filterpriority>
    public override IEnumerator<CxCriteriaOperator> GetEnumerator()
    {
      yield return this;
      foreach (CxCriteriaOperator @operator in Operand)
        yield return @operator;
    }
    //----------------------------------------------------------------------------
  }
}

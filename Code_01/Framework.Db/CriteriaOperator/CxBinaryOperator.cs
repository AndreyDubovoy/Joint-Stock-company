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

using System.Collections;
using System.Collections.Generic;

namespace Framework.Db
{
  /// <summary>
  /// A criteria operator that describes 
  /// relationships between property and its conditional value.
  /// </summary>
  public class CxBinaryOperator : CxCriteriaOperator
  {
    //----------------------------------------------------------------------------
    private CxCriteriaOperator m_LeftOperand;
    private CxCriteriaOperator m_RightOperand;
    private NxBinaryOperatorType m_OperatorType;
    //----------------------------------------------------------------------------

    #region Properties
    //----------------------------------------------------------------------------
    /// <summary>
    /// The left operand.
    /// </summary>
    public CxCriteriaOperator LeftOperand
    {
      get { return m_LeftOperand; }
      set { m_LeftOperand = value; }
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// The right operand.
    /// </summary>
    public CxCriteriaOperator RightOperand
    {
      get { return m_RightOperand; }
      set { m_RightOperand = value; }
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// A type of binary operator used between the property and value operands.
    /// </summary>
    public NxBinaryOperatorType OperatorType
    {
      get { return m_OperatorType; }
      set { m_OperatorType = value; }
    }
    //----------------------------------------------------------------------------
    #endregion

    #region Ctors
    //----------------------------------------------------------------------------
    /// <summary>
    /// Default ctor.
    /// </summary>
    public CxBinaryOperator()
    {
    }
    //----------------------------------------------------------------------------
    protected CxBinaryOperator(CxCriteriaOperator leftOperand, NxBinaryOperatorType type, CxCriteriaOperator rightOperand)
      : this()
    {
      LeftOperand = leftOperand;
      OperatorType = type;
      RightOperand = rightOperand;
    }

    //----------------------------------------------------------------------------
    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="property"></param>
    /// <param name="type"></param>
    /// <param name="value"></param>
    public CxBinaryOperator(CxPropertyOperand property, NxBinaryOperatorType type, CxValueOperand value)
      : this((CxCriteriaOperator) property, type, (CxCriteriaOperator) value)
    {
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="leftValue"></param>
    /// <param name="type"></param>
    /// <param name="rightValue"></param>
    public CxBinaryOperator(CxSimpleValueOperand leftValue, NxBinaryOperatorType type, CxSimpleValueOperand rightValue)
      : this((CxCriteriaOperator) leftValue, type, (CxCriteriaOperator) rightValue)
    {
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="leftProperty"></param>
    /// <param name="type"></param>
    /// <param name="rightProperty"></param>
    public CxBinaryOperator(
      CxPropertyOperand leftProperty, NxBinaryOperatorType type, CxPropertyOperand rightProperty)
      : this((CxCriteriaOperator) leftProperty, type, (CxCriteriaOperator) rightProperty)
    {
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
      return new CxBinaryOperator(LeftOperand.Clone(), OperatorType, RightOperand.Clone());
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
      foreach (CxCriteriaOperator @operator in LeftOperand)
        yield return @operator;
      foreach (CxCriteriaOperator @operator in RightOperand)
        yield return @operator;
    }
    //----------------------------------------------------------------------------
  }
}

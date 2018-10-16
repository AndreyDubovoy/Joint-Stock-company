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

using System.Collections.Generic;
namespace Framework.Db
{
  /// <summary>
  /// Represents a value operand.
  /// </summary>
  public class CxValueOperand: CxCriteriaOperator
  {
    //----------------------------------------------------------------------------
    private object m_Value;
    //----------------------------------------------------------------------------

    #region Properties
    //----------------------------------------------------------------------------
    /// <summary>
    /// A value retained by the operator.
    /// </summary>
    public object Value
    {
      get { return m_Value; }
      set { m_Value = value; }
    }
    //----------------------------------------------------------------------------
    #endregion

    #region Ctors
    //----------------------------------------------------------------------------
    /// <summary>
    /// Default ctor.
    /// </summary>
    public CxValueOperand()
    {
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="value"></param>
    public CxValueOperand(object value)
      : this()
    {
      Value = value;
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
      return MemberwiseClone() as CxValueOperand;
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
    }
    //----------------------------------------------------------------------------
  }
}

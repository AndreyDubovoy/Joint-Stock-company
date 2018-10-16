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
  /// A criteria operator that represents 
  /// "equals to one of the values" relation.
  /// </summary>
  public class CxInOperator: CxCriteriaOperator
  {
    //----------------------------------------------------------------------------
    private CxPropertyOperand m_PropertyOperand;
    private CxValueOperandList m_ValueOperands;
    //----------------------------------------------------------------------------
    #region Properties
    //----------------------------------------------------------------------------
    /// <summary>
    /// A property operand.
    /// </summary>
    public CxPropertyOperand PropertyOperand
    {
      get { return m_PropertyOperand; }
      set { m_PropertyOperand = value; }
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// A list of value operands.
    /// </summary>
    public CxValueOperandList ValueOperands
    {
      get { return m_ValueOperands; }
      set { m_ValueOperands = value; }
    }
    //----------------------------------------------------------------------------
    #endregion
    
    #region Ctors
    //----------------------------------------------------------------------------
    /// <summary>
    /// Default ctor.
    /// </summary>
    public CxInOperator()
    {
      ValueOperands = new CxValueOperandList();
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="property"></param>
    /// <param name="values"></param>
    public CxInOperator(
      CxPropertyOperand property, CxValueOperand[] values)
      : this()
    {
      PropertyOperand = property;
      ValueOperands.AddRange(values);
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
      CxValueOperand[] valueOperands = new CxValueOperand[ValueOperands.Count];
      for (int i = 0; i < ValueOperands.Count; i++)
      {
        valueOperands[i] = ValueOperands[i].Clone() as CxValueOperand;
      }
      return new CxInOperator(PropertyOperand.Clone() as CxPropertyOperand, valueOperands);
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
      foreach (CxCriteriaOperator @operator in PropertyOperand)
        yield return @operator;
      
      foreach (CxValueOperand valueOperand in ValueOperands)
      {
        foreach (CxCriteriaOperator @operator in valueOperand)
          yield return @operator;
      }
    }
    //----------------------------------------------------------------------------
  }
}

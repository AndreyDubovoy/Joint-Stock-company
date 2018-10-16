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
  //------------------------------------------------------------------------------
  /// <summary>
  /// A property operand.
  /// </summary>
  public class CxPropertyOperand: CxCriteriaOperator
  {
    //----------------------------------------------------------------------------
    private string m_PropertyName;
    //----------------------------------------------------------------------------

    #region Properties
    //----------------------------------------------------------------------------
    /// <summary>
    /// A name of the property.
    /// </summary>
    public virtual string PropertyName
    {
      get { return m_PropertyName; }
      set { m_PropertyName = value; }
    }
    //----------------------------------------------------------------------------
    #endregion

    #region Ctors
    //----------------------------------------------------------------------------
    /// <summary>
    /// Default ctor.
    /// </summary>
    public CxPropertyOperand()
    {
    }
    //----------------------------------------------------------------------------
    /// <summary>
    /// Ctor.
    /// </summary>
    /// <param name="propertyName"></param>
    public CxPropertyOperand(string propertyName)
      : this()
    {
      PropertyName = propertyName;
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
      return MemberwiseClone() as CxCriteriaOperator;
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
